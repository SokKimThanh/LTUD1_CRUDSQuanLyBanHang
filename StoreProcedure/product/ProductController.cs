using System.Data;
using System.Data.SqlClient;


public class ProductController : MyController
{
    public ProductController(string connectionString) : base(connectionString)
    {

    }

    public override bool Delete(object id)
    {
        bool flag = false;
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_product_delete", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@ma", id);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();

            flag = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        return flag;
    }

    public override object FromDataRow(DataRow row)
    {
        return new Product()
        {
            Ma = row.Field<string>("ma")!,
            Ten = row.Field<string>("ten")!,
            Gia = row.Field<decimal>("gia")!,
            Soluong = row.Field<int>("soluong")!,
            Loaisanpham = row.Field<string>("loaisanpham")!
        };
    }

    public override bool Insert(object sender)
    {
        bool flag = false;
        try
        {
            Product o = (Product)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_product_insert", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@ma", o.Ma);
            Sql.Parameters.AddWithValue("@ten", o.Ten);
            Sql.Parameters.AddWithValue("@gia", o.Gia);
            Sql.Parameters.AddWithValue("@soluong", o.Soluong);
            Sql.Parameters.AddWithValue("@loaisanpham", o.Loaisanpham);
            Sql.Parameters.AddWithValue("@nhacungcap", o.Nhacungcap);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
            flag = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        return flag;
    }

    public override DataTable SelectAll()
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_product_select_all", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        return DataSource;
    }

    public override DataRow SelectByID(object id)
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_product_select_one", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@ma", id);

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        // Trả về DataTable
        return DataSource.Rows[0];
    }

    public override bool Update(object sender)
    {
        bool flag = false;
        try
        {
            Product o = (Product)sender;
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_product_update", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Thêm tham số vào SqlCommand
            Sql.Parameters.AddWithValue("@ma", o.Ma);
            Sql.Parameters.AddWithValue("@ten", o.Ten);
            Sql.Parameters.AddWithValue("@gia", o.Gia);
            Sql.Parameters.AddWithValue("@soluong", o.Soluong);
            Sql.Parameters.AddWithValue("@loaisanpham", o.Loaisanpham);
            Sql.Parameters.AddWithValue("@nhacungcap", o.Nhacungcap);

            // Thực thi SqlCommand
            Sql.ExecuteNonQuery();

            // Đóng kết nối
            CloseConnection();
            flag = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        return flag;
    }

    public DataTable SelectCBOLoaiSanPham()
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_loaisanpham_cbo", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        return DataSource;
    }

    internal DataTable SelectCBONhaCungCap()
    {
        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_nhacungcap_cbo", conn);
            Sql.CommandType = CommandType.StoredProcedure;

            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        return DataSource;
    }

    internal DataTable SearchByName(string ten)
    {

        try
        {
            // Mở kết nối
            SqlConnection conn = OpenConnection();

            // Tạo một đối tượng SqlCommand
            Sql = new SqlCommand("sp_product_searchbyname", conn);
            Sql.CommandType = CommandType.StoredProcedure;
            Sql.Parameters.AddWithValue("@ten", ten);
            // Tạo một đối tượng SqlDataAdapter
            Adapter = new SqlDataAdapter(Sql);

            // Tạo một đối tượng DataTable để lưu trữ dữ liệu
            DataSource = new DataTable();

            // Đổ dữ liệu vào DataTable
            Adapter.Fill(DataSource);

            // Đóng kết nối
            CloseConnection();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Đóng kết nối
            CloseConnection();
        }
        return DataSource;
    }
}

