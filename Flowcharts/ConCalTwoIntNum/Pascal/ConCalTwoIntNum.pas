program MyProgram;
uses Math, SysUtils;

var
    n, m, a : integer;
    Cmd, More : string;
    Goodtogo, Doitagain : boolean;

begin
    Doitagain := true;
    while Doitagain = true do
    begin
        WriteLn('Enter n value');
        ReadLn(n);
        WriteLn('Enter m value');
        ReadLn(m);
        Goodtogo := false;
        while Goodtogo = false do
        begin
            WriteLn('Enter command');
            ReadLn(Cmd);
            if Cmd = 'add' then
            begin
                a := n + m;
                Goodtogo := true
            end;
            if Cmd = 'sub' then
            begin
                a := n - m;
                Goodtogo := true
            end;
            if Cmd = 'mul' then
            begin
                a := m * n;
                Goodtogo := true
            end;
            if Goodtogo = false then
            begin
                WriteLn('Bad command')
            end
        end;
        WriteLn('The answer is ' + FloatToStr(a));
        WriteLn('Do you want to Calculate again? (yes or no)');
        ReadLn(More);
        if More = 'yes' then
        begin
            Doitagain := true
        end
        else
        begin
            Doitagain := false
        end
    end;
    WriteLn('The program is done')
end.
