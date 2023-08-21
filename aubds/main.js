var counter = 1;
setInterval(function () {
  document.getElementById("radio" + counter).checked = true;
  counter++;
  if (counter > 3) {
    counter = 1;
  }
}, 4000);

// <!--******************
// Counter Animation
// ******************-->
const counters = document.querySelectorAll(".counter");
const speed = 1000; // The lower the slower

counters.forEach((counter) => {
  const updateCount = () => {
    const target = +counter.getAttribute("data-target");
    const count = +counter.innerText;

    // Lower inc to slow and higher to slow
    const inc = target / speed;

    // console.log(inc);
    // console.log(count);

    // Check if target is reached
    if (count < target) {
      // Add inc to count and output in counter
      counter.innerText = Math.ceil(count + inc);
      // Call function every ms
      setTimeout(updateCount, 1);
    } else {
      counter.innerText = target;
    }
  };

  updateCount();
});
//**************************************************

// ***********************
// Profile slide Animation
// ***********************

var pcounter = 1;
setInterval(function () {
  document.getElementById("pradio" + pcounter).checked = true;
  pcounter++;
  if (pcounter > 4) {
    pcounter = 1;
  }
}, 2000);
