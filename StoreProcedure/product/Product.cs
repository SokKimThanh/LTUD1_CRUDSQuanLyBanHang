
internal class Product
{
    private string ma;
    private string ten;
    private string loaisanpham;
    private string nhacungcap;
    private decimal gia;
    private int soluong;

    public Product()
    {

    }

    public Product(string ma, string ten, string loaisanpham, decimal gia, int soluong, string nhacungcap)
    {
        this.ma = ma;
        this.ten = ten;
        this.loaisanpham = loaisanpham;
        this.gia = gia;
        this.soluong = soluong;
        this.nhacungcap = nhacungcap;
    }

    public string Ma { get => ma; set => ma = value; }
    public string Ten { get => ten; set => ten = value; }
    public string Loaisanpham { get => loaisanpham; set => loaisanpham = value; }
    public decimal Gia { get => gia; set => gia = value; }
    public int Soluong { get => soluong; set => soluong = value; }
    public string Nhacungcap { get => nhacungcap; set => nhacungcap = value; }
}