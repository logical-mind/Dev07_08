using Okane.Domain;

namespace Okane.Application.Categories;

public interface ICategoriesRepository
{
    Category ByName(string categoryName);
    Category Add(Category category);
}