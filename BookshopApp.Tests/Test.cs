using BookshopApp.Models;
using BookshopApp.Views;

namespace BookshopApp.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void Author_FullName_ReturnsCorrectFormat()
        {
            // Arrange
            var author = new Author
            {
                last_name = "Пушкин",
                first_name = "Александр",
                middle_name = "Сергеевич"
            };

            // Act
            string fullName = author.FullName;

            // Assert
            Assert.AreEqual("Пушкин Александр Сергеевич", fullName);
        }

        [TestMethod]
        public void Author_FullName_WithoutMiddleName_ReturnsCorrectFormat()
        {
            // Arrange
            var author = new Author
            {
                last_name = "Толстой",
                first_name = "Лев",
                middle_name = null
            };

            // Act
            string fullName = author.FullName;

            // Assert
            Assert.AreEqual("Толстой Лев", fullName);
        }

        [TestMethod]
        public void TransactionViewModel_TotalSum_CalculatesCorrectly()
        {
            // Arrange
            var transaction = new Transaction();
            var bookTransaction1 = new BookTransaction
            {
                total_price = 350.50m,
                Transaction = transaction
            };
            var bookTransaction2 = new BookTransaction
            {
                total_price = 120.00m,
                Transaction = transaction
            };
            transaction.BookTransactions = new List<BookTransaction>
            {
                bookTransaction1, bookTransaction2
            };

            // Act
            var viewModel = new TransactionViewModel(transaction);

            // Assert
            Assert.AreEqual(470.50m, viewModel.TotalSum);
        }
    }
}