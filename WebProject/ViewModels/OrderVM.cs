using WebProject.Models;

namespace WebProject.ViewModels
{
	public class OrderVM
	{
		public OrderHeader OrderHeader { get; set; }
		public IEnumerable<OrderDetail> OrderDetail { get; set; }
	}
}
