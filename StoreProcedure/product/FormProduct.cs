using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.StoreProcedure.product
{
    public partial class FormProduct : Form
    {
        ProductController controller;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            this.controller = new ProductController(Utils.ConnectionString);
            // hien thi danh sach dgv
            dgvProduct.DataSource = controller.SelectAll();

            // hien thi danh sach cbo loai san pham
            cboLoaiSP.DataSource = controller.SelectCBOLoaiSanPham();
            cboLoaiSP.ValueMember = "ma";
            cboLoaiSP.DisplayMember = "ten";

            // hien thi danh sach cbo nhacungcap
            cboNhaCungCap.DataSource = controller.SelectCBONhaCungCap();
            cboNhaCungCap.ValueMember = "ma";
            cboNhaCungCap.DisplayMember = "ten";

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            //random ma sanpham
            Random d = new Random();
            txtMaSP.Text = "sp" + d.Next(10000, 999999);
            txtTenSP.Text = "sanpham" + d.Next(10000, 999999);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                //------------------------------------------------------
                //-----------cách để lấy id của một combobox------------
                //------------------------------------------------------
                string loaisanpham = cboLoaiSP.SelectedValue.ToString()!;
                //------------------------------------------------------
                //-----------cách để lấy id của một combobox------------
                //------------------------------------------------------
                string nhacungcap = cboNhaCungCap.SelectedValue.ToString()!;
                Product p = new Product(txtMaSP.Text, txtTenSP.Text, loaisanpham, decimal.Parse(txtGiaSP.Text), int.Parse(txtSoLuong.Text), nhacungcap);

                if (controller.Insert(p))
                {
                    MessageBox.Show("Thêm Thành công!");
                    dgvProduct.DataSource = controller.SelectAll();
                    btnadd.Enabled = false;
                    txtMaSP.Text = string.Empty;
                    txtTenSP.Text = string.Empty;
                    txtGiaSP.Text = string.Empty;
                    txtSoLuong.Text = string.Empty;
                    cboLoaiSP.SelectedIndex = 0;
                    cboNhaCungCap.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaSP.Text = dgvProduct.Rows[dong].Cells[0].Value.ToString();

                Product p = (Product)controller.FromDataRow(controller.SelectByID(txtMaSP.Text!));
                txtTenSP.Text = p.Ten;
                txtGiaSP.Text = p.Gia.ToString();
                txtSoLuong.Text = p.Soluong.ToString();
                txtMaSP.Text = p.Ma;
                cboLoaiSP.SelectedValue = p.Loaisanpham;

                // chophep thực hiện chức năng edit delete 
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnadd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Random d = new Random();
            txtMaSP.Text = "sp" + d.Next(10000, 999999);
            txtTenSP.Text = "sanpham" + d.Next(10000, 999999);
            txtGiaSP.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            cboLoaiSP.SelectedIndex = 0;
            cboNhaCungCap.SelectedIndex = 0;

            //cho phép thêm mới, khóa chức năng edit delete
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnadd.Enabled = true;

            //refresh lại danh sách dgv
            dgvProduct.DataSource = controller.SelectAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //------------------------------------------------------
                //-----------cách để lấy id của một combobox------------
                //------------------------------------------------------
                string loaisanpham = cboLoaiSP.SelectedValue.ToString()!;
                //------------------------------------------------------
                //-----------cách để lấy id của một combobox------------
                //------------------------------------------------------
                string nhacungcap = cboNhaCungCap.SelectedValue.ToString()!;
                Product p = new Product(txtMaSP.Text, txtTenSP.Text, loaisanpham, decimal.Parse(txtGiaSP.Text), int.Parse(txtSoLuong.Text), nhacungcap);

                if (controller.Update(p))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    // reset datagridview
                    dgvProduct.DataSource = controller.SelectAll();
                    btnadd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (controller.Delete(txtMaSP.Text))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvProduct.DataSource = controller.SelectAll();
                    btnadd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKeyWord.Text != string.Empty)
                {
                    dgvProduct.DataSource = controller.SearchByName(txtKeyWord.Text);
                }
                else
                {
                    //refresh lại danh sách dgv
                    dgvProduct.DataSource = controller.SelectAll();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
