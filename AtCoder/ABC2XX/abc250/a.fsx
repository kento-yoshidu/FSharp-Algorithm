// https://atcoder.jp/contests/abc250/tasks/abc250_a

let fn h w r c =
    [ h <> 1
      r <> 1 && r <> h
      w <> 1
      c <> 1 && c <> w ]
    |> List.filter id
    |> List.length

printfn "%i" (fn 3 4 2 2)
//=> 4

printfn "%i" (fn 3 4 1 3)
//=> 3

printfn "%i" (fn 3 4 3 4)
//=> 2
