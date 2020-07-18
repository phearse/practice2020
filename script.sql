CREATE TABLE "Department"
(
    "de_id" SERIAL PRIMARY KEY,
    "de_tittle" VARCHAR(50) NOT NULL
);
  
CREATE TABLE "Teachers"
(
    "te_id" SERIAL PRIMARY KEY,
    "de_id" INTEGER,
    "te_name" VARCHAR(50) NOT NULL,
    FOREIGN KEY ("de_id") REFERENCES "Department"("de_id") ON DELETE CASCADE ON UPDATE CASCADE
	);