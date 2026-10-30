--Execute comando por comando de acordo com os números que estão marcados caso precise recriar o banco de dados do ZERO
--Pois o PostgreeSQL diferente do MySQL não permite que você execute todo o script de 1X em uma mesma transação
--Por exemplo, não dá para dropar o banco e recriá-lo na mesma transação, por isso optei por separar cada um desses scripts e executar 1 por 1
--Pelo menos até onde eu sei
--OBS: Feito no PgMyAdmin 4

--01:
DROP DATABASE IF EXISTS vendinha;