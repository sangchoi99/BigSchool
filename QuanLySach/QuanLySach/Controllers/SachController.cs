using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {

            new Sach { Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName = "Nguyễn Nhật Ánh", Price = 1, Content="Truyện kể về Tuổi thơ..." },
            new Sach { Id = 2, Title = "Pro ASP.NET MVC5", AuthorName = "Adam Freeman", Content="The ASP.NET MVC 5 Framework is the latest evolution of Microsoft’s ASP.NET web platform.",  Price = 3.75M },
        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(string Title) // Khúc này, int: là số => string
        {
            var sach = sachs.FirstOrDefault((p) => p.Title == Title);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);


        }



    }
}
