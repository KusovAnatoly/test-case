SELECT
    product.product_name,
    category.category_name
FROM
    products
LEFT JOIN categories on product.category_id = category.category_id

/* либо с алиасами таблицы */

SELECT
    p.product_name,
    c.category_name
FROM
    products p
        LEFT JOIN categories c ON product.category_id = category.category_id