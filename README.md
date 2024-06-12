``Repo này sẽ mô tả một số ứng dụng của các phép toán bitwise trong phát triển ứng dụng.``

Dùng bitwise là một cách tuyệt vời, cực kì tối ưu cả về tốc độ tính toán lẫn sử dụng bộ nhớ. Repo này đưa ra ba trường hợp thực tế sử dụng bit và bitwise để xử lý.

## Lưu và xử lý quyền truy nhập
Thay vì lưu thành các giá trị riêng biệt, các quyền được lưu thành 1 bit trong 1 byte dữ liệu. Một bản ghi phân quyền trên tài nguyên sẽ là 4 bit cho 4 quyền phổ biến: Read, Write, Execute, Denied, tương đương 0b0000. Nếu người dùng được cấp nhiều role khác nhau, có nhiều bản ghi phân quyền khác nhau, việc tổng hợp lại các bản ghi này cũng rất dễ dàng và nhanh chóng. Chúng ta chỉ việc AND tất cả các bản ghi lại với bản ghi có quyền tương ứng. Ví dụ cần kiểm tra quyền Write, bản ghi quyền Write mặc định là 0b0100 (theo thứ tự được quy định phía trên). Dù có bao nhiều bản ghi thì nếu OR tất cả lại và AND với bản ghi Write mặc định này, kết quả sẽ luôn bẳng bản ghi Write mặc định nếu có quyền, hoặc 0 nếu không có quyền. Dễ dàng và nhanh chóng hơn việc tổng hợp các giá trị riêng lẻ. Chúng ta cũng có thể kiểm tra nhiều quyền cùng lúc mà không tăng độ phức tạp. Ví dụ cần kiểm tra cả quyền Write và Execute, bản ghi mặc định là 0b0110. Dùng phép AND với tất cả bản ghi mà kết quả vẫn bằng 0b0110 thì là thỏa mãn. Nếu lưu quyền dưới dạng một mảng, ta phải thực hiện vòng lặp hai lần để kiểm tra 2 quyền này.

Mã nguồn phần mô tả này nằm trong thư mục PermissionValidation. Các quyền được liệt kê dưới dạng 1 enum cho dễ đọc. Cách làm này khá phổ biến trong thư viện dotnet nếu các bạn để ý.

## Game
Một mảng hay một ma trận các bit là cách lưu state của game tuyệt vời. Mã nguồn dùng trò Bắn tàu để minh họa. Bạn sẽ thấy dùng bit ưu việt thế nào so với việc dùng một mảng 2 chiều các số nguyên để lưu bản đồ. Đối với các board game cần tìm các mẫu thỏa mãn cho trước, dùng các bit để lưu giúp việc matching các mẫu nhanh gọn, dễ dàng hơn hẳn (nếu dùng các mảng hai chiều, bạn phải thực hiện vòng lặp, còn với các bit, các phép bitwise cực tiết kiệm và ngắn gọn).

## Cộng dồn các options
Kĩ thuật này khá là phổ biến trong các thư viện hay framework nhưng lại không mấy khi được các lập trình viên học lại trong ứng dụng của mình. Liệt kê các lựa chọn của một hàm nào đó là dạng bit. Khi bạn thực hiện OR giữa các options, các option này đều được thể hiện trong số int ấy. Ví dụ lựa chọn Món Cá là 1 0b01, món Bò là 2 0b10. OR 2 món trên ta có số 3 là 0b11. AND với Cá thì sẽ cho ra Cá, AND với Bò thì sẽ cho ra Bò.

Mã nguồn giả định xay dựng NotificationService mà người dùng có quyền lựa chọn nhận tin nhắn qua các kênh Email, SMS hoặc Mobile app notification. 