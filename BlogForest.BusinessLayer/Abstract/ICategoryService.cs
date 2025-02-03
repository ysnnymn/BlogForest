using BlogForest.DtoLayer.CategoryDtos;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.BusinessLayer.Abstract;

public interface ICategoryService:IGenericService<Category>
{
   public  List<ResultCategoryWithCountDto> TGetCategoryWithCount();

    
}