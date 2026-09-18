using Microsoft.Data.SqlClient;
using System.Net.Mail;


namespace LabActivity4
{
    public partial class Form1 : Form
    {

        private decimal total;
        public Form1()
        {
            InitializeComponent();

            cmbDiscount.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            total = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["Price"].Value == null)
                    continue;

                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                total += price * quantity;
            }

            string discount = cmbDiscount.SelectedItem?.ToString() ?? "None";

            if (discount == "Student")
                total *= 0.9m;
            else if (discount == "Senior")
                total *= 0.85m;
            else if (discount == "BlackFriday")
                total *= 0.7m;

            lblTotal.Text = total.ToString("C");
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
                "Server=localhost;Database=Orders;Trusted_Connection=True;TrustServerCertificate=True;"

            );

            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO orders (Email, Total) VALUES (@e, @t)",
                conn

            );

            cmd.Parameters.AddWithValue("@e", txtCustomerEmail.Text);
            cmd.Parameters.AddWithValue("@e", total);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Saved!");
        }

        private void btnEmailnvoice_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            MailMessage mail = new MailMessage(
                "store@shop.com",
                txtCustomerEmail.Text
                );
            mail.Body = $"Your total is {total:C}";

            smtp.Send(mail);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Invoice for {txtCustomerEmail.Text}:{total:C}"

                );
        }
    }
}
