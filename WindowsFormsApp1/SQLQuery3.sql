select u.Id,u.Username, u.Email, c.FirstName+c.LastName as Fullname, c.IdentityNumber, c.Gender
from Users as u inner join Customers as c
on c.Id=u.Id;