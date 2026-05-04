// https://atcoder.jp/contests/abc456/tasks/abc456_b

let fn (s1: string) (s2: string) (s3: string) =
    let count =
        seq {
            for i in 0..6-1 do
            for j in 0.. 6-1 do
            for k in 0..6-1 do
                let arr = [| s1.[i]; s2.[j]; s3[k] |] |> Array.sort

                if arr = [| '4'; '5'; '6' |] then
                    yield 1.0
        }
        |> Seq.sum

    count / 216.0

printfn "%f" (fn "123456" "123456" "123456")
//=> 0.027778

printfn "%f" (fn "456456" "445566" "654456")
//=> 0.222222
