namespace Okane.Tests.Expenses.Retrieve;

public class RetrieveExpensesHandler : AbstractHandlerTests
{
    public RetrieveExpensesHandler()
    {
        CreateCategory(new("Food"));
        CreateCategory(new("Games"));
    }

    [Fact]
    public void NoExpenses() => 
        Assert.Empty(RetrieveExpenses());

    [Fact]
    public void OneExpenses()
    {
        CreateExpense(new(10, "Food"));

        var expense = Assert.Single(RetrieveExpenses());
        Assert.Equal(1, expense.Id);
        Assert.Equal(10, expense.Amount);
        Assert.Equal("Food", expense.CategoryName);
    }

    [Fact]
    public void ManyExpenses()
    {
        CreateExpense(new(10, "Food"));
        CreateExpense(new(20, "Games"));
        
        var response = RetrieveExpenses();
        
        Assert.Equal(2, response.Count());
    }
}