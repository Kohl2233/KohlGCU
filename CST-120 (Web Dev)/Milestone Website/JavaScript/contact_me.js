let contactForm = document.getElementById("contact_me_form"); // get the form element

contactForm.addEventListener("submit", (e) => {
    e.preventDefault();

    let firstName = document.getElementById("firstName"); // get first name value
    let lastName = document.getElementById("lastName"); // get last name value
    let email = document.getElementById("email"); // get the email value
    let contactReason = document.getElementById("reason"); // get the reason for contact value
    let message = document.getElementById("message"); // get the message value

    // Check if all fields have values
    if (firstName.value == "" || lastName.value == "" || email.value == "" || contactReason.value == "" || message.value == ""){
        alert("My dude... you gotta fill out the ENTIRE form. -___-");
    } else {
        alert("Thank you for completing the form! To see the entries, check the console in dev tools.");
        console.log(`First Name: ${firstName.value}\nLast Name: ${lastName.value}\nEmail: ${email.value}\nContact Reason: ${contactReason.value}\nMessage : ${message.value}`);
        
        // Reset Form Values post submission
        firstName.value = "";
        lastName.value = "";
        email.value = "";
        contactReason = "";
        message = "";
    };
});