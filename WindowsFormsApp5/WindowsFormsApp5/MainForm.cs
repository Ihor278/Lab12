using System;
using System.Windows.Forms;

namespace StringApp
{
    public partial class MainForm : Form
    {
        private BStringCollection collection = new BStringCollection();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int key = int.Parse(txtKey.Text);
                var bs = new BitString(txtValue.Text);
                collection.Add(key, bs);
                txtOutput.Text = "Item added successfully!";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowHash_Click(object sender, EventArgs e)
        {
            txtOutput.Text = collection.IterateHashtable();
        }

        private void btnShowSorted_Click(object sender, EventArgs e)
        {
            txtOutput.Text = collection.IterateSortedList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchKey.Text, out int key))
            {
                var result = collection.FindByKey(key);
                txtOutput.Text = result != null
                    ? $"Found: {result}"
                    : "Key not found";
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collection.GetCollectionStats(), "Collection Statistics");
        }
    }
}