
CREATE TABLE therapists (
    therapist_id INT PRIMARY KEY IDENTITY,
    last_name VARCHAR(30),
    first_name VARCHAR(30),
    phone_number VARCHAR(13),
   [user_name]  VARCHAR(30) NOT NULL UNIQUE,
   [password] VARCHAR(10) NOT NULL
);

CREATE TABLE emotions_categories(
catagory_id INT PRIMARY KEY IDENTITY,
catagory VARCHAR(150)
);

CREATE TABLE emotions(
emotion_id INT PRIMARY KEY IDENTITY,
catagory_id INT FOREIGN KEY REFERENCES emotions_categories(catagory_id),
emotion VARCHAR(100)
);

CREATE TABLE diagnosis_catagories(
catagory_id INT PRIMARY KEY IDENTITY,
catagory VARCHAR(MAX) CHECK(catagory = 'Psychiatric' OR catagory = 'psycological' )
);

CREATE TABLE diagnoses(
diagnosis_id INT PRIMARY KEY IDENTITY,
catagory_id INT FOREIGN KEY REFERENCES diagnosis_catagories(catagory_id),
needs_medication BIT
);

CREATE TABLE medications(
medication_id INT PRIMARY KEY IDENTITY,
[name] VARCHAR(MAX),
therapeutic_class VARCHAR(MAX),
[max_dosage] FLOAT
);


CREATE TABLE successes(
page_id INT PRIMARY KEY IDENTITY,
therapist_id INT,
patient_id INT,
successes_page NVARCHAR,
[date_time] DATE DEFAULT GETDATE()
);

CREATE TABLE patients(
patient_id INT PRIMARY KEY IDENTITY,
diagnosis_id INT FOREIGN KEY REFERENCES diagnoses(diagnosis_id),
first_name VARCHAR(30),
last_name VARCHAR(30),
phone_number VARCHAR(13) NOT NULL,
age INT,
family_status VARCHAR(30),
city VARCHAR(50),
[state] VARCHAR(50) DEFAULT (NULL),
country VARCHAR(50),
[doctors_phone_number] VARCHAR(13),
[user_name] VARCHAR(30) NOT NULL UNIQUE,
[password] VARCHAR(10) NOT NULL,
);

CREATE TABLE therapists_patients(
therapist_id INT,
patient_id INT,
[start_date] DATE,
charge FLOAT,
PRIMARY KEY (therapist_id, patient_id),
FOREIGN KEY (therapist_id) REFERENCES therapists(therapist_id),
FOREIGN KEY (patient_id) REFERENCES patients(patient_id)
);

CREATE TABLE patients_medications(
record_id INT PRIMARY KEY IDENTITY,
patient_id INT FOREIGN KEY REFERENCES patients(patient_id),
medication_id INT FOREIGN KEY REFERENCES medications(medication_id)



);

CREATE TABLE therapy_plan(
plan_id INT PRIMARY KEY,
therapist_id INT FOREIGN KEY REFERENCES therapists(therapist_id),
patient_id INT FOREIGN KEY REFERENCES patients(patient_id),
[plan] NVARCHAR,
[date_time] DATETIME DEFAULT GETDATE()
);
CREATE TABLE therapist_methods(
record_id INT PRIMARY KEY IDENTITY,
therapist_id INT,
patient_id INT,
method VARCHAR(100),
FOREIGN KEY (therapist_id) REFERENCES therapists(therapist_id),
FOREIGN KEY (patient_id) REFERENCES patients(patient_id)
);
CREATE TABLE session_summary(
summery_id INT PRIMARY KEY IDENTITY,
therapist_id INT  FOREIGN KEY REFERENCES therapists(therapist_id),
patient_id INT FOREIGN KEY REFERENCES patients(patient_id),
summery NVARCHAR,
session_number INT,
[is_therapist's] BIT,
[date_time] DATETIME DEFAULT GETDATE()
);

INSERT INTO  therapists (last_name, first_name, phone_number, user_name, password)
VALUES ('Avraham', 'Chani', '0533114466', 'chani4466', '1234');


SELECT * FROM therapists; 


