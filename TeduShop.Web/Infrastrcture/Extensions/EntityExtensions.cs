using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastrcture.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;


            postCategory.CreatedDate = postCategoryViewModel.CreatedDate;
            postCategory.CreatedBy = postCategoryViewModel.CreatedBy;
            postCategory.UpdateDate = postCategoryViewModel.UpdateDate;
            postCategory.UpdateBy = postCategoryViewModel.UpdateBy;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.Status = postCategoryViewModel.Status;




        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.CategoryID = postViewModel.CategoryID;
            post.Image = postViewModel.Image;
            post.Description = postViewModel.Description;
            post.Content = postViewModel.Content;
            post.HomeFlag = postViewModel.HomeFlag;
            post.HotFlag = postViewModel.HotFlag;
            post.ViewCount = postViewModel.ViewCount;

            post.CreatedDate = postViewModel.CreatedDate;
            post.CreatedBy = postViewModel.CreatedBy;
            post.UpdateDate = postViewModel.UpdateDate;
            post.UpdateBy = postViewModel.UpdateBy;
            post.MetaKeyword = postViewModel.MetaKeywork;
            post.MetaDescription = postViewModel.MetaDescription;
            post.Status = postViewModel.Status;

        }
        public static void UpdatePostTag(this PostTag postTag, PostTagViewModel postTagViewModel)
        {


           postTag.PostID = postTagViewModel.PostID;
            postTag.TagID = postTagViewModel.TagID;
            postTag.MetaKeyword = postTagViewModel.MetaKeyword;
            postTag.MetaDescription = postTagViewModel.MetaDescription;
            postTag.Status = postTagViewModel.Status;
            postTag.CreatedDate = postTagViewModel.CreatedDate;
            postTag.CreatedBy = postTagViewModel.CreatedBy;
            postTag.UpdateDate = postTagViewModel.UpdateDate;
            postTag.UpdateBy = postTagViewModel.UpdateBy;
        }
        public static void UpdateTag(this Tag tag, TagViewModel tagViewModel)
        {
            tag.ID = tagViewModel.ID;
            tag.Name = tagViewModel.Name;
            tag.Type = tagViewModel.Type;
        }
    }
}