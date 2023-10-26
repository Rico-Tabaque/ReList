/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html}"],
    theme: {
        extend: {
            fontFamily: { "default": ['Consolas', 'system-ui'] },
            backgroundImage: {
                "cactus": "url('../images/345689_1695963242507.png')"
            },
            backgroundSize: {
                "size": '20%',
            }
        },
    },
    plugins: [],
}

