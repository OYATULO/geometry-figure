select pr.product_name, cr.category_name  
	   from product   as pr  
       left join category as cr on cr.category_id = pr.product_category 
	   order by(pr.product_name)  asc 