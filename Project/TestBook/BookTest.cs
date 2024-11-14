using Project.Controllers;
using Project.Classes;

namespace TestBook
{
    public class BookTest
    {
        private readonly BookController bookController;

        public BookTest()
        {
            bookController = new BookController();
        }

        [Fact]
        public void Get_Id_IsOk()
        {
            //Arrange
            int id = 1;

            //Act
            var controller = new BookController();
            var res = controller.Get(id);

            //Assert
            Assert.IsType<Book>(res);
        }

    }
}