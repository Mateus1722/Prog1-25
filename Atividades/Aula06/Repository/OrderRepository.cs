using Modelo;

namespace Repository
{
    public class OrderRepository
    {
        public Order Retrieve(int id)
        {
            foreach (Order c in CustomerData.Orders)
                if (c.Id == id)
                    return c;

            return null!;
        }

        public List<Order> RetrieveByName(string name)
        {
            List<Order> ret = [];

            foreach (Order o in CustomerData.Orders)
                if (o.Customer.Name!.ToLower().Contains(name.ToLower()))
                    ret.Add(o);

            return ret;
        }

        public List<Order> RetrieveAll()
        {
            return CustomerData.Orders;
        }

        public void Save(Order order)
        {
            order.Id = Count + 1;
            CustomerData.Orders.Add(order);
        }

        public bool Delete(Order order)
        {
            return CustomerData.Orders.Remove(order);
        }

        public bool DeleteById(int id)
        {
            Order order = Retrieve(id);

            if (order != null)
                return Delete(order);

            return false;
        }

        public void Update(Order newOrder)
        {
            Order oldOder = Retrieve(newOrder.Id);
            oldOder.Customer = newOrder.Customer;
            oldOder.OrderDate = newOrder.OrderDate;
            oldOder.ShippingAddress = newOrder.ShippingAddress;
            oldOder.OrderItems = newOrder.OrderItems;

        }

        public int Count => CustomerData.Orders.Count;
    }
}