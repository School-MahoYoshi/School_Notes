-- 1
SELECT COUNT(1), MIN(login.lbe), MAX(login.lbe) FROM login;

-- 2
SELECT (SELECT COUNT(1) FROM user WHERE user.uirszam LIKE "1%")/COUNT(1)*100 AS arany FROM user;

-- 3
SELECT COUNT(1) as felhasznalok FROM user
	WHERE user.umail LIKE "%@postaladika.hu" AND user.ustatusz = "A";

-- 4
SELECT COUNT(1) as cnt, SUBSTRING_INDEX(user.umail, "@", -1) as levelezorendszer FROM user
	WHERE user.ustatusz = "A"
    GROUP BY SUBSTRING_INDEX(user.umail, '@', -1);

-- 5
SELECT COUNT(1) AS cnt, DATE(user.udatum) as datum FROM user
	GROUP BY datum
    HAVING cnt >= 3;

-- 6 
SELECT u.umail, u.upw FROM user u JOIN ( 
    SELECT upw, COUNT(*) AS cnt FROM user 
    GROUP BY upw 
    HAVING COUNT(*) > 1
) x ON u.upw = x.upw
	ORDER BY u.upw;