using M1_Partial_Library;
using M1_Partial_Library.Data;
using M1_Partial_Library.DataAccess;
using M1_Partial_Library.Objects;
using Microsoft.Extensions.Configuration;
using System.Drawing.Design;
namespace InventoryManagerApp
{
    public partial class InventoryManager : Form
    {
        SqlData db = GetConnection();
        public InventoryManager()
        {
            InitializeComponent();

        }

        static SqlData GetConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("C:\\GitHub\\EmbornasM1Project\\InventoryManagerApp\\appsettings.json");
            IConfiguration config = builder.Build();
            ISqlDataAccess dbAccess = new SqlDataAccess(config);
            SqlData db = new SqlData(dbAccess);
            return db;
        }
        private int s_itemId;
        void showItems()
        {
            List<Item> items = db.ReadAllItems();
            itemsTable.DataSource = items;
        }
        void addItem()
        {
            try
            {
                Item newItem = new Item
                {
                    Name = txtName.Text,
                    Code = txtCode.Text,
                    Brand = txtBrand.Text,
                    UnitPrice = int.Parse(txtPrice.Text)
                };
                db.addItem(newItem);
                MessageBox.Show("Item has been added.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showItems();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Unit Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Please Check Program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void findItem()
        {
            try
            {
                string idString = txtID.Text;
                int id = Int32.Parse(idString);
                Item item = db.ReadData(id);

                List<Item> items = new List<Item> { item };
                itemsTable.DataSource = items;
                MessageBox.Show("Item has been found", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input valid item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not find the item you are looking for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateItem()
        {
            try
            {
                Item updateItem = new Item
                {
                    Id = s_itemId,
                    Name = txtName.Text,
                    Code = txtCode.Text,
                    Brand = txtBrand.Text,
                    UnitPrice = int.Parse(txtPrice.Text)
                };
                db.UpdateData(updateItem);
                MessageBox.Show("Item has been updated.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showItems();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Unit Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error, Please Check Program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DeleteItem()
        {
            db.DeleteData(s_itemId);
            MessageBox.Show("Item has been deleted.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showItems();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = itemsTable.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtPrice.Text = row.Cells["UnitPrice"].Value.ToString();

                int itemId;
                if (int.TryParse(row.Cells["Id"].Value.ToString(), out itemId))
                {
                    this.s_itemId = itemId;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showItems();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            findItem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }
    }
}
