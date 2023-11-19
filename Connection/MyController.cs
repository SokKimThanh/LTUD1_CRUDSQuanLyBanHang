
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Lớp MyController điều khiển thao tác trên cơ sở dữ liệu dữ liệu và chiến thuật đóng mở kết nối
/// là một lớp trừu tượng chứa một thể hiện của DatabaseConnection và cung cấp hai phương thức bảo vệ để mở và đóng kết nối
/// là một lớp trừu tượng kế thừa interface DBController chứa các phương thức định nghĩa sẵn để thao tác trên cơ sở dữ liệu
/// </summary>
public abstract class MyController : DBController
{
    /// <summary>
    /// Đây là một chiến lược tốt để quản lý kết nối cơ sở dữ liệu. Bằng cách đặt nó như một thành viên bảo vệ, các lớp kế thừa có thể sử dụng nó để mở và đóng kết nối.
    /// </summary>
    private DatabaseConnection dbConnection;
    /// <summary>
    /// Property này cho phép bạn truy cập và chỉnh sửa listgridview từ các lớp kế thừa. Điều này có thể hữu ích nếu bạn muốn hiển thị dữ liệu từ cơ sở dữ liệu lên giao diện người dùng.
    /// </summary>
    private DataTable listgridview;
    /// <summary>
    /// SqlDataAdapter là một đối tượng bridge giữa DataSet và SQL Server để lấy dữ liệu và lưu dữ liệu. SqlDataAdapter hoạt động với SqlCommand để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataSet. Khi bạn thực hiện các thao tác Cập nhật hoặc Xóa trên dữ liệu trong DataSet thì SqlDataAdapter sẽ thực hiện việc cập nhật này lên cơ sở dữ liệu. Property Adapter cho phép bạn truy cập và chỉnh sửa adapter từ các lớp kế thừa.
    /// </summary>
    private SqlDataAdapter adapter;
    /// <summary>
    /// Đối tượng SqlCommand biểu diễn một câu lệnh SQL hoặc một thủ tục đã lưu để thực thi trên SQL Server. Các lớp kế thừa có thể sử dụng nó để thực thi các câu lệnh SQL. Property Sql cho phép bạn truy cập và chỉnh sửa sql từ các lớp kế thừa.
    /// </summary>
    private SqlCommand sql;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public MyController(string connectionString)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        dbConnection = new DatabaseConnection(connectionString);
    }

    

    /// <summary>
    /// Đây là một chiến lược tốt để quản lý kết nối cơ sở dữ liệu. Bằng cách đặt nó như một thành viên bảo vệ, các lớp kế thừa có thể sử dụng nó để mở và đóng kết nối.
    /// </summary>
    protected DatabaseConnection DbConnection { get => dbConnection; set => dbConnection = value; }
    /// <summary>
    /// Property này cho phép bạn truy cập và chỉnh sửa listgridview từ các lớp kế thừa. Điều này có thể hữu ích nếu bạn muốn hiển thị dữ liệu từ cơ sở dữ liệu lên giao diện người dùng.
    /// </summary>
    public DataTable DataSource { get => listgridview; set => listgridview = value; }
    /// <summary>
    /// SqlDataAdapter là một đối tượng bridge giữa DataSet và SQL Server để lấy dữ liệu và lưu dữ liệu. SqlDataAdapter hoạt động với SqlCommand để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataSet. Khi bạn thực hiện các thao tác Cập nhật hoặc Xóa trên dữ liệu trong DataSet thì SqlDataAdapter sẽ thực hiện việc cập nhật này lên cơ sở dữ liệu. Property Adapter cho phép bạn truy cập và chỉnh sửa adapter từ các lớp kế thừa.
    /// </summary>
    public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
    /// <summary>
    /// Đối tượng SqlCommand biểu diễn một câu lệnh SQL hoặc một thủ tục đã lưu để thực thi trên SQL Server. Các lớp kế thừa có thể sử dụng nó để thực thi các câu lệnh SQL. Property Sql cho phép bạn truy cập và chỉnh sửa sql từ các lớp kế thừa.
    /// </summary>
    public SqlCommand Sql { get => sql; set => sql = value; }



    public SqlConnection OpenConnection()
    {
        return dbConnection.OpenConnection();
    }

    public void CloseConnection()
    {
        dbConnection.CloseConnection();
    }

    public abstract bool Insert(object sender);


    public abstract bool Update(object sender);


    public abstract bool Delete(object id);


    public abstract DataTable SelectAll();


    public abstract DataRow SelectByID(object id);


    public abstract object FromDataRow(DataRow row);
     
}
