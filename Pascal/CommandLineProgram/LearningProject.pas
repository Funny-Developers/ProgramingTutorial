program LearningProject;                                  (*定义一个程序*)

var i:integer;                                            (*定义一个整型参数i*)

function loop(a:integer):boolean;                         (*定义一个返回布尔值的函数loop, 其参数为整型a*)
begin                                                     (*函数体开始*)
  i := 0;                                                 (*定义i为0*)
  while i <= a do                                         (*当i小于等于a时执行...*)
    begin                                                 (*循环体开始*)
    writeln(i);                                           (*输出i的值并换行*)
    i := i + 1;                                           (*定义i的值为i+1*)
    end;                                                  (*循环体结束*)
end;                                                      (*函数体结束*)

function prepare(x1, x2:longint):boolean;                 (*定义一个返回布尔值的函数prepare, 其参数为长整型x1, x2*)
begin                                                     (*函数体开始*)
  if x1 > x2 then writeln('x1 is greater than x2.');      (*比较x1与x2的大小, 若x1大于x2则输出"x1 is greater than x2."*)
  if x1 < x2 then writeln('x1 is less than x2.');         (*比较x1与x2的大小, 若x1小于x2则输出"x1 is less than x2."*)
  if x1 = x2 then writeln('x1 is equals to x2.');         (*比较x1与x2的大小, 若x1等于x2则输出"x1 is equals to x2."*)
  readln;
end;                                                      (*函数体结束*)

begin                                                     (*程序主体开始*)
  loop(100);                                              (*执行函数loop, 参数为100*)
  readln;                                                 (*等待回车输入*)
  loop(10);                                               (*执行函数loop, 参数为10*)
  readln;                                                 (*等待回车输入*)
  prepare(100, 10);                                       (*执行函数prepare, 参数为100, 10*)
  prepare(10, 100);                                       (*执行函数prepare, 参数为10, 100*)
  prepare(100, 100);                                      (*执行函数prepare, 参数为100, 100*)
  readln;                                                 (*等待回车输入*)
end.                                                      (*程序结束*)

