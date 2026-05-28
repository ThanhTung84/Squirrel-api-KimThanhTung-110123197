using Microsoft.AspNetCore.Mvc;
using squirrel_api_hoten_mssv.Models;

namespace squirrel_api_hoten_mssv.Controllers
{
    [ApiController]
    [Route("api/giaodich")] // Định nghĩa route chuẩn theo đề bài: /api/giaodich
    public class TransactionController : ControllerBase
    {
        // Dùng bộ nhớ static để lưu trữ dữ liệu mẫu gốc ban đầu giống như file hướng dẫn mẫu
        private static List<Transaction> dsGiaoDich = new List<Transaction>();

        public TransactionController()
        {
            // Khởi tạo cứng 5 dòng dữ liệu mẫu nếu danh sách đang trống
            if (dsGiaoDich.Count == 0)
            {
                dsGiaoDich.Add(new Transaction { Id = 1, SoTaiKhoan = "1023456789", SoTien = 500000, LoaiGiaoDich = "Nap tien" });
                dsGiaoDich.Add(new Transaction { Id = 2, SoTaiKhoan = "1023456789", SoTien = 200000, LoaiGiaoDich = "Rut tien" });
                dsGiaoDich.Add(new Transaction { Id = 3, SoTaiKhoan = "1098765432", SoTien = 1000000, LoaiGiaoDich = "Nap tien" });
                dsGiaoDich.Add(new Transaction { Id = 4, SoTaiKhoan = "1098765432", SoTien = 1500000, LoaiGiaoDich = "Rut tien" });
                dsGiaoDich.Add(new Transaction { Id = 5, SoTaiKhoan = "1055566677", SoTien = 300000, LoaiGiaoDich = "Nap tien" });
            }
        }

        // 1. Phương thức GET: Lọc xuất ra danh sách loại giao dịch "Nap tien" dạng JSON
        [HttpGet]
        public ActionResult LayGiaoDichNapTien()
        {
            var dsNapTien = dsGiaoDich.Where(t => t.LoaiGiaoDich == "Nap tien").ToList();
            return Ok(dsNapTien);
        }

        // 2. Phương thức POST: Giúp bạn test thêm dữ liệu mới giống như luồng chạy của file hướng dẫn
        [HttpPost]
        public ActionResult ThemGiaoDichMau()
        {
            int tiepTheo = dsGiaoDich.Count + 1;
            // Tự động thêm một giao dịch nạp tiền mới để kiểm tra tính linh hoạt
            dsGiaoDich.Add(new Transaction { 
                Id = tiepTheo, 
                SoTaiKhoan = "1055566699", 
                SoTien = 100000 * tiepTheo, 
                LoaiGiaoDich = "Nap tien" 
            });
            return Ok();
        }
    }
}