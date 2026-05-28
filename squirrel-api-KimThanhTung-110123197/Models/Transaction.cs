namespace squirrel_api_hoten_mssv.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string SoTaiKhoan { get; set; } = string.Empty;
        public double SoTien { get; set; }
        public string LoaiGiaoDich { get; set; } = string.Empty;
    }
}