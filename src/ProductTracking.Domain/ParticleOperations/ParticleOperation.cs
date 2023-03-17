using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ProductTracking.ParticleOperations
{
	[Table("ParticleOperation",Schema ="dbo")]
	public class ParticleOperation : Entity<int>
	{
		[Column("Operation_Code")]
		public string OperationCode { get; set; }
		[Column("Operation_Description")]
		public string OperationDescription { get; set; }
		[Column("O_Start_Date")]
		public DateTime? OperationStartDate { get; set; }
		[Column("O_End_Date")]
		public DateTime? OperationEndDate { get; set;}
		[Column("O_Status")]
		public string OperationStatus { get; set;}
		[Column("Station")]
		public string Station { get; set; }
		[Column("O_Track_Code")]
		public string OperationTrackCode { get; set; }

	}
}
