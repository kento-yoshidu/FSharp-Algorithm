// https://atcoder.jp/contests/arc040/tasks/arc040_a

let run n (strings: string list) =
  let t, a =
    strings
      |> Seq.collect id
      |> Seq.fold (fun (r, b) c ->
        match c with
          | 'R' -> (r+1, b)
          | 'B' -> (r, b+1)
          | _ -> (r, b)) (0, 0)

  if t > a then "TAKAHASHI"
  elif a > t then "AOKI"
  else "DRAW"

printfn "%s" (run 4 ["R.RB"; "RR.B"; "BRBB"; "RRB."])
//=> TAKAHASHI

printfn "%s" (run 2 [".."; ".."])
//=> DRAW

printfn "%s" (run 3 ["BRB"; "RBR"; "BRB"])
//=> AOKI
