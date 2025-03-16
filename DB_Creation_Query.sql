DROP DATABASE IF EXISTS dbperrona;
CREATE DATABASE IF NOT dbperrona;
USE dbperrona;
CREATE TABLE Items (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    type VARCHAR(50) NOT NULL,
    STR INT DEFAULT 0,
    AGI INT DEFAULT 0,
    INTE INT DEFAULT 0,
    MND INT DEFAULT 0,
    VIT INT DEFAULT 0,
    description TEXT
);

GRANT SELECT ON dbperrona.Items TO 'lectura'@'localhost';
FLUSH PRIVILEGES;

INSERT INTO Items (name, type, STR, AGI, INTE, MND, VIT, description) VALUES
    ('Espada del Héroe', 'Arma', 15, 5, 0, 0, 10, 'Una espada legendaria de un antiguo héroe.'),
    ('Daga del Asesino', 'Arma', 5, 20, 0, 0, 5, 'Daga afilada usada por asesinos expertos.'),
    ('Bastón Arcano', 'Arma', 0, 5, 20, 10, 0, 'Bastón imbuido con poder arcano.'),
    ('Escudo de Hierro', 'Escudo', 5, 0, 0, 0, 20, 'Un resistente escudo de hierro forjado.'),
    ('Armadura de Placas', 'Armadura', 10, 0, 0, 0, 25, 'Armadura pesada que ofrece gran protección.'),
    ('Guantes de Ladrón', 'Accesorio', 2, 10, 0, 0, 0, 'Aumenta la destreza y velocidad del usuario.'),
    ('Anillo de Sabiduría', 'Accesorio', 0, 0, 10, 15, 0, 'Un anillo que incrementa la inteligencia y mente.'),
    ('Capa de Sombras', 'Armadura', 0, 15, 5, 5, 5, 'Capa que permite moverse sigilosamente.'),
    ('Martillo de Titanes', 'Arma', 25, 0, 0, 0, 15, 'Un martillo gigante que puede aplastar montañas.'),
    ('Botas de Velocidad', 'Accesorio', 0, 20, 0, 0, 0, 'Aumenta enormemente la velocidad del usuario.'),
    ('Espada Rúnica', 'Arma', 10, 5, 5, 0, 5, 'Espada encantada con antiguas runas mágicas.'),
    ('Maza Sagrada', 'Arma', 15, 0, 0, 10, 10, 'Maza bendecida por sacerdotes de la luz.'),
    ('Arco de Cazador', 'Arma', 5, 15, 0, 0, 5, 'Arco usado por cazadores expertos en la selva.'),
    ('Báculo de Hechicero', 'Arma', 0, 5, 25, 10, 0, 'Canaliza energías místicas para lanzar conjuros.'),
    ('Espada Maldita', 'Arma', 20, 0, -5, 0, 10, 'Otorga gran poder, pero consume la mente del usuario.'),
    ('Anillo de Vitalidad', 'Accesorio', 0, 0, 0, 0, 20, 'Incrementa la resistencia y vitalidad.'),
    ('Cinturón del Guerrero', 'Accesorio', 10, 5, 0, 0, 5, 'Refuerza la fuerza y resistencia del usuario.'),
    ('Pergamino de Protección', 'Objeto', 0, 0, 10, 10, 0, 'Crea un escudo mágico temporal.'),
    ('Poción de Fuerza', 'Consumible', 10, 0, 0, 0, 0, 'Aumenta temporalmente la fuerza del usuario.'),
    ('Poción de Velocidad', 'Consumible', 0, 10, 0, 0, 0, 'Incrementa la agilidad por unos minutos.'),
    ('Casco del Conquistador', 'Armadura', 5, 0, 0, 0, 10, 'Casco usado por un gran general de guerra.'),
    ('Varita de Relámpagos', 'Arma', 0, 5, 15, 10, 0, 'Canaliza poderosos relámpagos contra los enemigos.'),
    ('Coraza del Paladín', 'Armadura', 10, 0, 0, 5, 20, 'Armadura bendecida con protección sagrada.'),
    ('Anillo de Invisibilidad', 'Accesorio', 0, 10, 0, 0, 0, 'Otorga la habilidad de volverse invisible brevemente.'),
    ('Guantelete de Poder', 'Accesorio', 15, 0, 0, 0, 5, 'Aumenta la fuerza del usuario de forma considerable.'),
    ('Espada de Cristal', 'Arma', 10, 5, 5, 5, 0, 'Forjada con cristales mágicos que potencian el ataque.'),
    ('Túnica de Mago', 'Armadura', 0, 0, 15, 10, 5, 'Ropaje encantado con poder arcano.'),
    ('Lanza de Dragón', 'Arma', 20, 5, 0, 0, 10, 'Una lanza usada por cazadores de dragones.'),
    ('Cetro del Rey', 'Arma', 5, 5, 10, 15, 5, 'Símbolo de poder que otorga habilidades mágicas.'),
    ('Libro de Conjuros', 'Objeto', 0, 0, 25, 15, 0, 'Contiene antiguos hechizos de gran poder.'),
    ('Arco Elfico', 'Arma', 5, 20, 5, 0, 5, 'Arco bendecido por los elfos del bosque.'),
    ('Botas de Gravedad', 'Accesorio', 0, 15, 0, 0, 10, 'Permite saltos más altos y aterrizajes seguros.'),
    ('Máscara del Ilusionista', 'Accesorio', 0, 5, 10, 10, 0, 'Facilita engañar a los enemigos con ilusiones.'),
    ('Escudo de Adamantita', 'Escudo', 10, 0, 0, 0, 30, 'Escudo casi indestructible hecho de adamantita.'),
    ('Espada Flamígera', 'Arma', 15, 5, 5, 0, 10, 'Una espada envuelta en llamas eternas.'),
    ('Collar de Protección', 'Accesorio', 5, 5, 5, 5, 10, 'Otorga protección contra ataques mágicos y físicos.'),
    ('Látigo de Espinas', 'Arma', 10, 15, 0, 0, 5, 'Un látigo afilado que causa heridas profundas.');
