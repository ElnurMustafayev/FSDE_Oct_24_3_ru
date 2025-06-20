namespace DelegatesApp.Delegates;

public delegate void MyParameterlessDelegate();
public delegate void MyParameterizedDelegate(object obj);

public delegate bool CheckNumberWithResultListDelegate(List<bool> results, int num);
public delegate bool CheckNumberDelegate(int num);

public delegate bool MyPredicate(int num);
public delegate void MyAction(int num);