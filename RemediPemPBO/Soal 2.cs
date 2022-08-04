using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RemediPemPBO
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(
            "data source = localhost;" +
            "initial catalog = Northwind;" +
            "integrated security = true;"
            );
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        public Form1()
        {
            InitializeComponent();

            // Inisialisasi Data Awal
            adapter = new SqlDataAdapter("SELECT OrderID FROM [Order Details] GROUP BY OrderID", conn);
            builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            recordList.DataSource = ds.Tables[0];
            recordList.ReadOnly = true;
            recordList.AllowUserToAddRows = false;
            totalRecord.Text = recordList.Rows.Count.ToString();
        }

        private void recordList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string currentOrderId = recordList.SelectedCells[0].Value.ToString();
            string cmd = string.Format("SELECT ProductID, UnitPrice, Quantity as Qty, Discount as Disc FROM [Order Details] WHERE OrderID = '{0}'", currentOrderId);
            adapter = new SqlDataAdapter(cmd, conn);
            builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            orderDetailList.DataSource = ds.Tables[0];
            orderDetailList.AllowUserToAddRows = false;
            orderDetailList.ReadOnly = true;

            float total = 0;
            for (int i = 0; i < orderDetailList.Rows.Count; i++)
            {
                float temp = 0;
                
                temp = float.Parse(orderDetailList.Rows[i].Cells[1].Value.ToString()) * float.Parse(orderDetailList.Rows[i].Cells[2].Value.ToString());
                if (float.Parse(orderDetailList.Rows[i].Cells[3].Value.ToString()) > 0)
                    temp = temp * float.Parse(orderDetailList.Rows[i].Cells[3].Value.ToString());
                total += temp;
            }
            totalPrice.Text = "$ " + total.ToString();
            SqlCommand command = new SqlCommand(string.Format("SELECT Customers.ContactName FROM Orders INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID AND OrderID = '{0}'", currentOrderId), conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                contactName.Text = reader.GetValue(0).ToString();
            }
            conn.Close();


        }

        private void orderId_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(string.Format("SELECT OrderID FROM [Order Details] WHERE OrderID LIKE '%{0}%' GROUP BY OrderID", orderId.Text), conn);
            builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            recordList.DataSource = ds.Tables[0];
            totalRecord.Text = recordList.Rows.Count.ToString();
        }
    }
}
