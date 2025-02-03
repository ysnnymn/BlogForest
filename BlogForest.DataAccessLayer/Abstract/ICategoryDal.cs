using BlogForest.DtoLayer.CategoryDtos;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.DataAccessLayer.Abstract;

public interface ICategoryDal:IGenericDal<Category>
{
    List<ResultCategoryWithCountDto> GetCategoryWithCount();
}