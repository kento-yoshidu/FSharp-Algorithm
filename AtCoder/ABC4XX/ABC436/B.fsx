// https://atcoder.jp/contests/abc436/tasks/abc436_b

let fn n =
    let ans = Array2D.create n n 0

    let mutable r = 0
    let mutable c = (n - 1) / 2
    let mutable k = 1

    ans[r, c] <- k

    for _ in 1 .. n * n - 1 do
        let nr = (r + n - 1) % n
        let nc = (c + 1) % n
        k <- k + 1

        if ans[nr, nc] = 0 then
            ans[nr, nc] <- k
            r <- nr
            c <- nc
        else
            let dr = (r + 1) % n
            ans[dr, c] <- k
            r <- dr

    ans

printfn "%A" (fn 3)
//=> [[8; 1; 6] [3; 5; 7] [4; 9; 2]]

printfn "%A" (fn 5)
//=> [[17; 24; 1; 8; 15] [23; 5; 7; 14; 16] [4; 6; 13; 20; 22] [10; 12; 19; 21; 3] [11; 18; 25; 2; 9]]
