using BaiThi_MVC_DinhVanHoangAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiThi_MVC_DinhVanHoangAn.Util
{
    public class DropDownListUtil
    {
        private static BaiThi_MVC_DinhVanHoangAnContext db = new BaiThi_MVC_DinhVanHoangAnContext();
        private static List<ExamSubject> _listSub;
        private static List<ClassRoom> _listClass;
        private static List<Faculty> _listFaculty;

        public static List<ExamSubject> GetSubs()
        {
            List<ExamSubject> lstSub = new List<ExamSubject>()
            {
                new ExamSubject()
                {
                    Id = 1,
                    Name = "CoreJava"
                },
                new ExamSubject()
                {
                    Id = 2,
                    Name = "AdvanceJava"
                },
                new ExamSubject()
                {
                    Id = 3,
                    Name = "ProgrammingC"
                },

            };
            if (_listSub == null)
            {
                _listSub = lstSub;
            }
            return _listSub;
        }

        public static List<ClassRoom> GetClasses()
        {
            List<ClassRoom> lstClass = new List<ClassRoom>()
            {
                new ClassRoom()
                {
                    Id = 1,
                    Name = "B10"
                },
                new ClassRoom()
                {
                    Id = 2,
                    Name = "B16"
                },
                new ClassRoom()
                {
                    Id = 3,
                    Name = "B14"
                },

            };
            if (_listClass == null)
            {
                _listClass = lstClass;
            }
            return _listClass;
        }

        public static List<Faculty> GetFaculties()
        {
            List<Faculty> lstFaculty = new List<Faculty>()
            {
                new Faculty()
                {
                    Id = 1,
                    Name = "Jaya"
                },
                new Faculty()
                {
                    Id = 2,
                    Name = "John"
                },
                new Faculty()
                {
                    Id = 3,
                    Name = "HienPA"
                },

            };

            if (_listFaculty == null)
            {
                _listFaculty = lstFaculty;
            }
            return _listFaculty;
        }

        public static List<SelectListItem> GetSubjectsAsDropDownList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<ExamSubject> lstSub = new List<ExamSubject>()
            {
                new ExamSubject()
                {
                    Id = 1,
                    Name = "CoreJava"
                },
                new ExamSubject()
                {
                    Id = 2,
                    Name = "AdvanceJava"
                },
                new ExamSubject()
                {
                    Id = 3,
                    Name = "ProgrammingC"
                },

            };

            if (_listSub == null)
            {
                _listSub = lstSub;
            }

            foreach (var item in _listSub)
            {
                list.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            return list;
        }

        public static List<SelectListItem> GetClassesAsDropDownList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<ClassRoom> lstClass = new List<ClassRoom>()
            {
                new ClassRoom()
                {
                    Id = 1,
                    Name = "B10"
                },
                new ClassRoom()
                {
                    Id = 2,
                    Name = "B16"
                },
                new ClassRoom()
                {
                    Id = 3,
                    Name = "B14"
                },

            };

            if (_listClass == null)
            {
                _listClass = lstClass;
            }

            foreach (var item in _listClass)
            {
                list.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            return list;
        }

        public static List<SelectListItem> GetFacultiesAsDropDownList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<Faculty> lstFaculty = new List<Faculty>()
            {
                new Faculty()
                {
                    Id = 1,
                    Name = "Jaya"
                },
                new Faculty()
                {
                    Id = 2,
                    Name = "John"
                },
                new Faculty()
                {
                    Id = 3,
                    Name = "HienPA"
                },

            };

            if (_listFaculty == null)
            {
                _listFaculty = lstFaculty;
            }

            foreach (var item in _listFaculty)
            {
                list.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            return list;
        }
    }
}