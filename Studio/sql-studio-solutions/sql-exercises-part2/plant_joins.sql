# Inner Join

SELECT * 
FROM seeds
INNER JOIN garden_bed ON (seeds.plant_id=garden_bed.plant_id);

# Left Outer Join

SELECT * 
FROM seeds
LEFT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id;

# Right Outer Join

SELECT *
FROM seeds
RIGHT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id;

# Simulated Full Outer Join

SELECT * FROM seeds LEFT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id
UNION
SELECT * FROM seeds RIGHT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id; 