
CREATE DATABASE IF NOT EXISTS okul
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_turkish_ci;

USE okul;

DROP TABLE IF EXISTS ogrenciler;

CREATE TABLE ogrenciler (
  id INT AUTO_INCREMENT PRIMARY KEY,
  ad VARCHAR(50) NOT NULL,
  soyad VARCHAR(50) NOT NULL,
  numara VARCHAR(20) NOT NULL UNIQUE,
  sinif VARCHAR(10) NOT NULL,
  telefon VARCHAR(20) NOT NULL
);

INSERT INTO ogrenciler (ad, soyad, numara, sinif, telefon) VALUES
('Ayşe', 'Yılmaz', '1001', '12-A', '5321112233'),
('Mehmet', 'Demir', '1002', '12-A', '5322223344'),
('Zeynep', 'Kaya', '1003', '12-A', '5323334455'),
('Emre', 'Şahin', '1004', '12-B', '5324445566'),
('Elif', 'Çelik', '1005', '12-B', '5325556677'),
('Burak', 'Aydın', '1006', '12-B', '5326667788'),
('Selin', 'Arslan', '1007', '12-C', '5327778899'),
('Can', 'Koç', '1008', '12-C', '5328889900'),
('Fatma', 'Öztürk', '1009', '12-C', '5329990011'),
('Hakan', 'Yıldız', '1010', '12-A', '5330001122');
