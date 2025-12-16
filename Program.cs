using System;

class StudentService
{
    public void ShowMenu()
    {
        Console.WriteLine("=== Student Service Menu ===");
        Console.WriteLine("1. ตรวจสอบเกรดเฉลี่ย");
        Console.WriteLine("2. ตรวจสอบค่าเทอม");
        Console.WriteLine("3. แสดงข้อมูลนักศึกษา");
        Console.WriteLine("4. ออกจากโปรแกรม");
        Console.Write("เลือกเมนู: ");
    }

    public void ProcessMenu(int menu)
    {
        switch (menu)
        {
            case 1:
                ShowGPA();
                break;
            case 2:
                ShowTuitionFee();
                break;
            case 3:
                ShowStudentInfo();
                break;
            case 4:
                Console.WriteLine("ออกจากโปรแกรม...");
                break;
            default:
                Console.WriteLine("กรุณาเลือกเมนู 1-4 เท่านั้น");
                break;
        }

        Console.WriteLine("----------------------------");
    }

    private void ShowGPA()
    {
        double gpa = 3.21;
        Console.WriteLine("เกรดเฉลี่ย (GPA) ของคุณคือ: " + gpa);
    }

    private void ShowTuitionFee()
    {
        int fee = 15000;
        Console.WriteLine("ค่าเทอมของคุณคือ: " + fee + " บาท");
    }

    private void ShowStudentInfo()
    {
        Console.WriteLine("ชื่อ: นายสมชาย ใจดี");
        Console.WriteLine("รหัสนักศึกษา: 654123001");
        Console.WriteLine("สาขา: เทคโนโลยีสารสนเทศ");
    }
}
