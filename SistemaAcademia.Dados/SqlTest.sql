INSERT INTO Alunos (NomeCompleto, CPF, DataNascimento, Logradouro, CEP, Bairro, Cidade, EstadoUF) VALUES ('LEONARDO WIZENFARD DE OLIVEIRA', '43309118843', '1995/08/30', 'AV JOSÉ DE ALENCAR, N 436', '19160000', 'JARDIM PANORAMA', 'ÁLVARES MACHADO', 'SP');

INSERT INTO AlunosTelefones (AlunoId, DDD, Numero, Tipo, PossuiWhatsApp) VALUES (5, '18', '988063916', 1, 0)

INSERT INTO Exercicios (Descricao) VALUES ('SUPINO RETO');
INSERT INTO Exercicios (Descricao) VALUES ('SUPINO INCLINADO');
INSERT INTO Exercicios (Descricao) VALUES ('PULLEY');
INSERT INTO Exercicios (Descricao) VALUES ('VOADOR');
INSERT INTO Exercicios (Descricao) VALUES ('PUXADOR FRONTAL');
INSERT INTO Exercicios (Descricao) VALUES ('PUXADOR BAIXO');

INSERT INTO Treinos (AlunoId, NumeroMaximoTreino, NumeroAtualTreino, Tipo) VALUES (5, 40, 0, 'A');
INSERT INTO Treinos (AlunoId, NumeroMaximoTreino, NumeroAtualTreino, Tipo) VALUES (5, 40, 0, 'B');
INSERT INTO Treinos (AlunoId, NumeroMaximoTreino, NumeroAtualTreino, Tipo) VALUES (5, 40, 0, 'C');

INSERT INTO TreinosExercicios (TreinoId, ExercicioId, NumeroSeries, NumeroRepeticoes) VALUES (1, 1, 4, 12);
INSERT INTO TreinosExercicios (TreinoId, ExercicioId, NumeroSeries, NumeroRepeticoes) VALUES (1, 2, 4, 12);
INSERT INTO TreinosExercicios (TreinoId, ExercicioId, NumeroSeries, NumeroRepeticoes) VALUES (1, 3, 4, 12);
INSERT INTO TreinosExercicios (TreinoId, ExercicioId, NumeroSeries, NumeroRepeticoes) VALUES (1, 4, 4, 12);

INSERT INTO TreinosHistoricos (AlunoId, DataTreino, UltimoTreinoId, ProximoTreinoId) values (5, GETDATE(), 2, 3)

SELECT * FROM Alunos
SELECT * FROM AlunosTelefones
SELECT * FROM Exercicios
SELECT * FROM Treinos
SELECT * FROM TreinosExercicios
SELECT * FROM TreinosHistoricos
