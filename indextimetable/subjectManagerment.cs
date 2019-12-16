using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indextimetable
{
    public class subjectManagerment
    {
        public List<Table> getSubject()
        {
            var db = new TKBEntities();
            List<Table> subject = db.Tables.ToList();
            return subject;
        }
        public Table getSubjects(int ID)
        {
            var db = new TKBEntities();
            var subject = db.Tables.Find(ID);
            return subject;
        }
        public void createSubject(string CaHoc , string thu2, string thu3,string thu4,string thu5,string thu6,string thu7)
        {
            var db = new TKBEntities();
            var newSubject = new Table();
            newSubject.Ca_Học = CaHoc;
            newSubject.Thứ_Hai = thu2;
            newSubject.Thứ_Ba = thu3;
            newSubject.Thứ_Tư = thu4;
            newSubject.Thứ_Năm = thu5;
            newSubject.Thứ_Sáu = thu6;
            newSubject.Thứ_Bảy = thu7;
            db.Tables.Add(newSubject);
            db.SaveChanges();
            db.Dispose();
        }
        public void updateSubject(int id, string CaHoc, string thu2, string thu3, string thu4, string thu5, string thu6, string thu7)
        {
            var db = new TKBEntities();
            var currentSubject = db.Tables.Find(id);
            currentSubject.Ca_Học = CaHoc;
            currentSubject.Thứ_Hai = thu2;
            currentSubject.Thứ_Ba = thu3;
            currentSubject.Thứ_Tư = thu4;
            currentSubject.Thứ_Năm = thu5;
            currentSubject.Thứ_Sáu = thu6;
            currentSubject.Thứ_Bảy = thu7;
            db.Entry(currentSubject).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
        public bool IsValidLogin(string taiKhoan, string matKhau)
        {
            TKBEntities db = new TKBEntities();
            List<TaiKhoan> listTK = db.TaiKhoans.ToList();
            TaiKhoan temp = new TaiKhoan();
            temp.taiKhoan1 = taiKhoan;
            temp.matKhau = matKhau;
            bool isValid = false;
            for (int i = 0; i < listTK.Count; i++)
            {
                if (listTK[i].taiKhoan1 == temp.taiKhoan1 &&
                    listTK[i].matKhau == temp.matKhau)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
