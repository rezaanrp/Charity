﻿let quiz = [
    { question: "از صحبت کردن با دیگران انرژی میگیرم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "شناختن من نسبتا آسان است و من در نظر دیگران شخصی دوستانه و معاشرتی هستم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من در ملاقات و بودن با اشخاص جدید راحت هستم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم کانون توجه باشم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "اهل صحبت هستم و اغلب ارتباط کلامی را به ارتباط کتبی ترجیح می دهم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "تقریبا با هرکس حرفی برای صحبت پیدا می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من دوستان و آشنایان فراوان دارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "اگر مدت طولانی تنها بمانم، احساس بیقراری فراوان و تنهایی می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "باید مراقب باشم تا به دیگران هم فرصت حرف زدن بدهم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من با صحبت کردن به نتیجه گیری می رسم. من با صدای بلند فکر می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "در برنامه های اجتماعی و در میهمانیهایی که دیگران را نمی شناسم راحت نیستم. اما ترجیح می دهم با کسی که او را می شناسم گفتگوی دو نفره داشته باشم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم وقت زیادی را به تنهایی بگذارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "ترجیح می دهم تعدادمعدودی دوست داشته باشم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "ترجیح می دهم به جای اینکه من به سمت دیگران بروم، دیگران به سمت من بیایند.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "اشخاص اغلب مرا خجالتی ارزیابی می کنند.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "قبل از اینکه حرف بزنم مدتی وقت می گذارم و فکر میکنم که چه باید بگویم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "اگر زمان زیادی با اشخاص صرف کنم حوصله ام سر می رود. حتی صحبت تلفنی اگر طولانی شود مرا خسته می کند.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "ترجیح می دهم به تنهایی روی پروژه ها کار کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "درباره اینکه با چه کسی طرح دوستی بریزم بسیار انتخابی عمل می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست ندارم کانون توجه باشم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم عملی و واقع بین باشم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به ارقام و آمار بیش از نظریه توجه می کنم", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من کارهایی را دوست دارم که کاربرد عملی داشته باشد و نتایج ملموس تولید کند.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم حرف بزنم، بشنوم و تفسیر کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من مشاهده گر خوبی هستم. به اطرافم نگاه می کنم و اغلب جزئیات را به خاطر می سپارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "پروژه های دستی مثل، ساختن مدلهای اتومبیل، سوار کردن چیزها یا سوزن دوزی را دوست دارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم از مهارتهایی که دارم استفاده کنم و آنها را بهتر کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من از اینجا و اکنون لذت می برم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به تجربه شخصی خود از چیزهای واقعی و مشخص، اعتماد می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "به جای توجه به آینده دور به آنچه در دست است توجه دارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "برای من توجه کردن به حال حاضر دشوار است. چون من اغلب درباره چند موضوع و مورد مختلف در آن واحد فکر می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "به هنگام توضیح دادن یا توصیف کردن چیزی از استعاره و قیاس استفاده می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به الهام و برخورد اول و تصور برای کسب اطلاعات متکی هستم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم به امکانات جدید و به آنچه ممکن است وجود داشته باشد فکر کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به آینده نظردارم و دوست دارم کارهای نو و ابتکاری بکنم و از کارهای تکراری و مشخص بدم می آید.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به تصویرهای بزرگ و کلی توجه می کنم. دوست ندارم به جزئیات بپردازم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به کاربردها و استنباطها توجه دارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من فضای میان سطرها را می خوانم و به مطالبی که مطرح نشده اند فکر می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به انچه در پیرامونم می گذرد توجه کمی دارم. به اینجا و اکنون توجه نمی کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من از انتزاع و نظریه خوشم می آید و گاهی توجه به جزئیات زندگی روزمره کسل کننده است.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "می توانم به خوبی فکر کنم و تصمیم بگیرم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم درباره نقطه نظرم بحث کنم. گاهی فقط برای رقابت ذهنی، درباره هر دو جنبه یک مسئله بحث می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من متهم شده ام که به نیازها و احساسات دیگران بها نمی دهم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "اشخاص گاهی مرا تحلیل گر می پندارند.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "می توانم رک و بی پرده باشم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به اندیشه دیگران بیش از احساس آنها بها می دهم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست ندارم احساساتم را به نمایش بگذارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من اغلب بر اساس عدالت و منطق تصمیم می گیرم، نه بر اساس موضوعات شخصی.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "به نظر من صادق بودن بهتر از رعایت جنبه های ادب است.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من از اصلاح کردن و انتقاد نمودن از دیگران خجالت نمی کشم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من همدل و مهربان هستم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم درباره روابط میان فردی و احساساتم صحبت کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "در فرایند تصمیم گیری، برایم بسیار مهم است که تصمیم من روی دیگران چه تاثیری دارد.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "رعایت ادب به اندازه صداقت اهمیت دارد.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "مورد تعریف و قدرشناسی واقع شدن برای من بسیار مهم است.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "بدنبال پیدا کردن چیزهای خوب در افراد و چیزها هستم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "مردم مرا به خاطر گرما و صمیمیتم می خواهند.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "صحبت کردن درباره خواسته هایم برای من دشوار است.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "وقتی با اشخاص مخالفت می کنم، برای من دشور است موضوع را با آنها در میان بگذارم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من انتقاد شخص را به دل می گیرم. می گویند که من بیش از اندازه حساس هستم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست ندارم موضوعی را بدون تصمیم گیری رها کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "اگر محیط من سازمان یافته نباشد برایم آرام گرفتن دشوار می شود.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "فهرستی از کارهایی را که باید انجام دهم تهیه می کنم و بعد هر کاری را که انجام دادم با علامت مشخص می نمایم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من کارها را به سبک و روش خودم انجام می دهم. دوست ندارم دیگران بخواهند به خصوص در آخرین لحظه برنامه مرا تغییر دهند.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم برای هر چیزی جایی داشته باشم و همه چیزهایم در جای خودش باشد.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "قبل از آنکه پروژه ای را شروع کنم به این فکر می کنم که چه چیزی را نیاز دارم. دقت می کنم که همه چیز سر جای خودش باشد.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "برایم به موقع و سروقت بودن بسیار مهم است و برایم عجیب است که چرا این برای دیگران در الویت قرار ندارد.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم درباره برنامه ها و چارچوب های زمانی اطلاع پیدا کنم. اگر برنامه ای در کار نباشد ناراحت می شوم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست ندارم کارم را ناتمام رها کنم. دوست دارم قبل از شروع هر پروژه ، پروژه قبلی را تمام کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "قبل از اینکه بتوانم استراحت کنم باید کارم را تمام کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من به نسبت راحت، تطبیق پذیر و با انعطاف هستم. وقتی در آخرین لحظه تغییری ایجاد می شود، خودم را با آن تطبیق می دهم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "نه اینکه من به چیزی توجه ندارم. من به شیوه خودم عمل می نمایم و از یک پروژه به سراغ پروژه بعدی می روم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "دوست دارم پروژه های جدیدی را شروع کنم. معمولا قبل از تمام کردن پروژه قبلی به سر وقت پروژه بعدی می روم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "طبق برنامه بودن برای من مهمترین چیز زندگی نیست.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من معمولا فهرست کارهایی را که معمولا باید انجام بدهم تهیه نمی کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "اغلب سعی می کنم تا ضرب الاجل نزدیک شود و بعد پروژه را تمام می کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "طرز سازمان دادن به اتاق یا دفتر کارم در نظر دیگران نمونه آشفتگی است.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "مجبور نیستم که کارم را تمام کنم تا بتوانم آرام بگیرم و استراحت کنم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من تصمیم گیریها را به تعویق می اندازم، اغلب آنقدر اطلاعات جمع می کنم تا وقت تصمیم گیری الزامی می شود.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
    { question: "من از چیزهای غیر منتظره لذت می برم.", option: ["ابدا این طور نیستم", "تا اندازه ای این طور هستم", "کاملا این طور هستم", "$$",], answer: 3, },
];