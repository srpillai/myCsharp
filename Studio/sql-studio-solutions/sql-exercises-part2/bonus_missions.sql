# Get count of complex inner join

-- SELECT COUNT(plant_name)
-- FROM plant
-- INNER JOIN 
-- 	(SELECT seeds.plant_id FROM seeds INNER JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id) AS planted_plants ON plant.plant_id=planted_plants.plant_id;


# Try out UNION ALL in simulated full outer join

-- SELECT * FROM seeds LEFT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id
-- UNION ALL
-- SELECT * FROM seeds RIGHT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id; 

SELECT plant_name FROM plant
INNER JOIN (SELECT seeds.plant_id FROM seeds LEFT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id
	UNION ALL
	SELECT seeds.plant_id FROM seeds RIGHT JOIN garden_bed ON seeds.plant_id=garden_bed.plant_id) AS planted_plants ON plant.plant_id=planted_plants.plant_id;
