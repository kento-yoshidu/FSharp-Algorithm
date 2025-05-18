// https://atcoder.jp/contests/abc393/tasks/abc393_a

let fn s1 s2 =
    if s1 = "sick" && s2 = "sick" then
        1
    elif s1 = "fine" && s2 = "fine" then
        4
    elif s1 = "sick" then
        2
    else
        3

printfn "%i" (fn "sick" "fine")
//=> 2

printfn "%i" (fn "fine" "fine")
//=> 4
