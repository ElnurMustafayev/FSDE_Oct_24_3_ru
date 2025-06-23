namespace DelegatesApp.Delegates;

public delegate void MyParameterlessDelegate();
public delegate void MyParameterizedDelegate(object obj);

public delegate bool CheckNumberWithResultListDelegate(List<bool> results, int num);
public delegate bool CheckNumberDelegate(int num);

public delegate bool MyPredicate(int num);
public delegate void MyAction(int num);

public delegate void MyAction<T>(T obj);
public delegate bool MyPredicate<T>(T obj);
public delegate T2 MyFunc<T1, T2>(T1 obj);