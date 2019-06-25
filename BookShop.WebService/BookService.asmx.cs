
using BookShop.DAL;
using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BookShop.WebService
{
    /// <summary>
    /// BookService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX·
    //从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class BookService : System.Web.Services.WebService
    {
        //实例化数据访问层
        private BookDAL bookDAL = new BookDAL();

        //图书Book服务，获取所有的图书 

        [WebMethod]
        public List<Book> GeTBooks(string orderby = "")
        { 
            return bookDAL.GeTbooks(orderby);
        }

        //获取图书信息通过分页
        [WebMethod]
        //图书分页
        public List<Book> GetBooksByPage(int currentPage, int PageSize, string orderyby="id")
        {
            //调用DAL层
            return bookDAL.GetBooksByPage(currentPage, PageSize, orderyby);
        }
        public int GetBookCount()
        {
            //调用DAL层
            return bookDAL.GetBookCount();
        }
        //图书分页
        public List<Book> GetBooksByPage(int currentPage, int PageSize)
        {
            //调用DAL层
            return bookDAL.GetBooksByPage(currentPage, PageSize);
        }

        //获取图书信息通过排序字段
        public List<Book> GetBooksByOrderStr(string strOrderField)
        {
            //调用DAL层

            return bookDAL.GetBooksByOrder(strOrderField);
        }

        //通过Id获取图书
        public Book GetBookById(int id)
        {

            return bookDAL.GetBookById(id);
        }
    }
}
