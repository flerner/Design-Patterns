using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _iterator = _collection.CreateIterator();
            InitializeComponent();
        }

        private Collection _collection = new ConcreteCollection();
        private IteratorExample _iterator;
        private void ListCollection()
        {
            listBox1.Items.Clear();
            _iterator.First();
            Item i = _iterator.CurrentItem();
            if(i != null )
            {
                listBox1.Items.Add( i );
            }
            while (!_iterator.IsDone())
            {
                _iterator.Next();
                listBox1.Items.Add(_iterator.CurrentItem());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var _item = new Item(txtBoxInputItem.Text);
            _collection.Add(_item);

            ListCollection();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            _iterator.First();
            txtBoxFirst.Text = _iterator.CurrentItem().Name;
            txtBoxNext.Text = _iterator.CurrentItem().Name;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!_iterator.IsDone())
            {
                _iterator.Next();
                txtBoxNext.Text = _iterator.CurrentItem().Name;
            }
            else
            {
                txtBoxNext.Text = "End of collection";
            }
        }
    }
}
