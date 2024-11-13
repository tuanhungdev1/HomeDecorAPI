using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.UserDtos
{
	public class UserUpdateRolesDto
	{
		[Required]
        public List<string> Roles { get; set; }
    }
}
