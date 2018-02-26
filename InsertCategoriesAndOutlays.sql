INSERT INTO 
	Category ([Name], BudgetedAmount, ActivityAmount, AvailableAmount) 
VALUES
	('Groceries', 200, 0, 0),
	('Transportation', 80, 0, 0),
	('Gifts', 40, 0, 0),
	('Eating Out', 100, 0, 0)

INSERT INTO
	Outlay (CategoryID, DateOccurred, DateEntered, Amount, Payee, Memo)
VALUES
	(4, GetDate(), GetDate(), 10, 'Panda Express', 'Saturday is for the boys')