using KtC_1;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Service sv = new Service();
int menu;
do
{
    Console.WriteLine("1. Nhập 1 danh sách đối tượng");
    Console.WriteLine("2. Xuất danh sách đối tượng");
    Console.WriteLine("3. Xuất danh sách SV được tặng vé vip HappyBee (Điểm >= 8)");
    Console.WriteLine("4. Xóa những sinh viên không được tham gia HappyBee nếu không được tặng (Tuổi > 25)");
    Console.WriteLine("5. Kế thừa");
    Console.WriteLine("0. Thoát");
    Console.Write("Vui lòng nhập chương trình cần chọn :");
    menu = Convert.ToInt32(Console.ReadLine());
    switch (menu)
    {
        case 0:
            Console.WriteLine("Kết thúc chương trình!!");
            break;
        case 1:
            Console.WriteLine("1. Nhập 1 danh sách đối tượng");
            sv.Nhap();
            break;
        case 2:
            Console.WriteLine("2. Xuất danh sách đối tượng");
            sv.Xuat1();
            break;
        case 3:
            Console.WriteLine("3. Xuất danh sách SV được tặng vé vip HappyBee (Điểm >= 8)");
            sv.Xuat2();
            break;
        case 4:
            Console.WriteLine("4. Xóa những sinh viên không được tham gia HappyBee nếu không được tặng (Tuổi > 25)");
            sv.Xoa();
            break;
        case 5:
            Console.WriteLine("5. Kế thừa");
            sv.KeThua();
            break;
        default:
            Console.WriteLine("Không có chương trình cần tìm");
            break;
    }

} while (menu != 0);
