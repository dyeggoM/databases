using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.Databases.DBModels.Models
{
	public class Property : BaseModel<int>
	{
		public string Name { get; set; }
	}
}
