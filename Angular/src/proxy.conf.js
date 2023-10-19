const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
    ],
    target: "http://localhost:1234",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
