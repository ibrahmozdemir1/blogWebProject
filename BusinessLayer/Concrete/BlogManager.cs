using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
            throw new NotImplementedException();
        }

		public List<Blog> GetBlogById(int id)
		{
			return _blogDal.GetListAll(x => x.BlogID == id);
		}

		public List<Blog> getList()
		{
			return _blogDal.GetListAll();
		}

		public List<Blog> getLastThreePost()
		{
			return _blogDal.GetListAll().Take(3).ToList();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDal.GetListAll(x => x.WriterID == id);
        }

		public void Add(Blog t)
		{
			_blogDal.Insert(t);
		}

		public void Remove(Blog t)
		{
			throw new NotImplementedException();
		}

		public void Update(Blog t)
		{
			throw new NotImplementedException();
		}
	}
}
