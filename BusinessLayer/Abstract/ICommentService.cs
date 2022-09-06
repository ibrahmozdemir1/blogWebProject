using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CategoryRemove(Comment category);
        //void CategoryUpdate(Comment category);
        List<Comment> getList(int id);
        //Category GetById(int id);
    }
}
