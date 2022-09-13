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
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void Add(About t)
		{
			throw new NotImplementedException();
		}

		public About GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<About> getList()
		{
            return _aboutDal.GetListAll();
        }
		public void Remove(About t)
		{
			throw new NotImplementedException();
		}

		public void Update(About t)
		{
			throw new NotImplementedException();
		}
	}
}
