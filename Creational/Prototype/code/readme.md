System noise in audio recordings can be distracting, but Audacity has powerful tools to help clean up and improve your audio quality. Here's a step-by-step guide to reduce system noise and enhance your MP2 audio file:

---

### 1. **Remove Background Noise**
   Audacity has a built-in Noise Reduction tool.

   - **Step 1**: Highlight a portion of your recording where only the system noise (background noise) is present. 
     - Play the audio to identify a "silent" section with just the noise.
   - **Step 2**: Go to `Effect > Noise Reduction`.
   - **Step 3**: Click on `Get Noise Profile`. This tells Audacity what to remove.
   - **Step 4**: Select the entire track (or the section you want to clean), then go back to `Effect > Noise Reduction`.
   - **Step 5**: Adjust the settings:
     - Noise Reduction (dB): 6–12 dB is usually a good range to start with.
     - Sensitivity: Around 6–10 works well for most cases.
     - Frequency Smoothing: 3–6 is a good range.
   - **Step 6**: Preview and apply. Adjust if needed to balance noise removal without losing audio quality.

---

### 2. **Use Equalization**
   To make the audio sound cleaner and more balanced:
   - **Step 1**: Go to `Effect > Filter Curve EQ`.
   - **Step 2**: Reduce low frequencies below 50 Hz (these often carry hum or rumbles).
   - **Step 3**: Gently boost mid and high frequencies (2–8 kHz) to enhance clarity, but don’t overdo it.

---

### 3. **Apply a High-Pass Filter**
   This removes low-frequency hum and rumble:
   - **Step 1**: Go to `Effect > High-Pass Filter`.
   - **Step 2**: Set the cutoff frequency to around 80 Hz (or higher, depending on the noise).
   - **Step 3**: Apply and listen to ensure clarity.

---

### 4. **Normalize or Amplify**
   If the audio volume varies:
   - **Step 1**: Go to `Effect > Normalize`.
   - **Step 2**: Set the peak amplitude to -1.0 dB for safe levels.
   - **Optional**: Use `Effect > Amplify` to make the audio louder.

---

### 5. **Compress for Consistent Levels**
   To even out loud and soft parts:
   - **Step 1**: Go to `Effect > Compressor`.
   - **Step 2**: Set:
     - Threshold: -12 dB to -20 dB (depending on the quietest sound).
     - Ratio: 3:1 or 4:1 for subtle compression.
     - Attack and Release: Short values (e.g., 5 ms and 100 ms) work for most speech.

---

### 6. **Add Final Enhancements (Optional)**
   - **Reverb**: Add subtle reverb to improve natural sound quality (`Effect > Reverb`).
   - **De-Esser**: If you have harsh "s" sounds, use a de-essing plugin (e.g., Spitfish).

---

### 7. **Export as MP2**
   Once you’re satisfied with the improvements:
   - Go to `File > Export > Export as MP2`.
   - Ensure you select a high bit rate (e.g., 192 kbps or higher) for better quality.

---

### Pro Tips:
- **Use Headphones**: This helps you hear the changes more accurately.
- **Save a Backup**: Always work on a copy of your original audio to avoid losing data.
- **Experiment**: Adjust settings based on the specific noise and quality of your audio.

If the noise is particularly persistent, consider using a dedicated noise reduction plugin like **iZotope RX** for advanced cleanup.
